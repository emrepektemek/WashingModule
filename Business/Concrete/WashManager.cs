﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.UserContext;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WashManager : IWashService
    {

        private IWashDal _washDal;

        private IWashingTypeService _washingTypeService;    

        private IUserContextService _userContextService;

        public WashManager(IWashDal washDal, IUserContextService userContextService, IWashingTypeService washingTypeService)
        {
            _washDal = washDal;
            _userContextService = userContextService;
            _washingTypeService = washingTypeService;
        }

        [ValidationAspect(typeof(WashValidator))]
        public IResult Add(Wash wash)
        {
            var washToCheck = WashExists(wash);

            var timeControl = WashTimeControl(wash);

            var machineBusyControl = MachineBusyControl(wash);

            if (washToCheck != null)
            {
                return new ErrorResult(Messages.WashAlreadtExists);
            }

            if (!timeControl)
            {
                return new ErrorResult(Messages.WashInProgress);
            }

            if (!machineBusyControl)
            {
                return new ErrorResult(Messages.MachineBusy);
            }

            int userId = _userContextService.GetUserId();

            if (userId == 0)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

            var newWash = new Wash
            {
                OrderId = wash.OrderId,
                WashingTypeId = wash.WashingTypeId,
                MachineId = wash.MachineId,
                Shift = wash.Shift,
                CreatedUserId = userId,
                CreatedDate = DateTime.Now,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };


            _washDal.Add(newWash);

            return new SuccessResult(Messages.WashAdded);
        }

        public IDataResult<List<WashingDto>> GetAll()
        {
            return new SuccessDataResult<List<WashingDto>>(_washDal.GetAllForWashing());
        }

        public Wash WashExists(Wash wash)
        {
            return _washDal.Get(w => w.OrderId == wash.OrderId && w.WashingTypeId == wash.WashingTypeId);
        }

        public bool WashTimeControl(Wash wash)
        {
            var lastWash = _washDal.GetAll(w => w.OrderId == wash.OrderId).OrderByDescending(w => w.CreatedDate).FirstOrDefault();

            if (lastWash == null)
            {
                return true;
            }

            var washingType = _washingTypeService.GetById(lastWash.WashingTypeId);

            if (washingType == null)
            {
                return true;
            }

            var washEndTime = lastWash.CreatedDate.AddMinutes(washingType.WashingTime);

            if (DateTime.Now <= washEndTime)
            {
                return false;
            }


            return true;

        }


        public bool MachineBusyControl(Wash wash)
        {
            var lastMachineWash = _washDal.GetAll(w => w.MachineId == wash.MachineId).OrderByDescending(w => w.CreatedDate).FirstOrDefault();

            if (lastMachineWash == null)
            {
                return true;
            }

            var washingType = _washingTypeService.GetById(lastMachineWash.WashingTypeId);

            var machineWashEndTime = lastMachineWash.CreatedDate.AddMinutes(washingType.WashingTime);

            if (DateTime.Now <= machineWashEndTime)
            {
                return false;
            }

            return true;

        }


    }
}
