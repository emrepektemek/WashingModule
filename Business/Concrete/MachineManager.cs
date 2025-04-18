using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.UserContext;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MachineManager : IMachineService
    {

        private IMachineDal _machineDal;

        private IUserContextService _userContextService;
        public MachineManager(IMachineDal machineDal, IUserContextService userContextService)
        {
            _machineDal = machineDal;
            _userContextService = userContextService;
        }

        [ValidationAspect(typeof(MachineValidator))]
        public IResult Add(Machine machine)
        {
            var machineToCheck = MachineExists(machine);

            if (machineToCheck != null)
            {
                return new ErrorResult(Messages.MachineAlreadtExists);
            }

            int userId = _userContextService.GetUserId();

            if (userId == 0)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

            var newMachine = new Machine
            {
                MachineName = machine.MachineName,
                MachineType = machine.MachineType,
                CreatedUserId = userId,  
                CreatedDate = DateTime.Now,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,             
                Status = true,
                IsDeleted = false  
            };


            _machineDal.Add(newMachine);

            return new SuccessResult(Messages.MachineAdded);
            
        }

        public IDataResult<List<Machine>> GetAll()
        {
            return new SuccessDataResult<List<Machine>>(_machineDal.GetAll());

        }

        public Machine MachineExists(Machine machine)
        {
            return _machineDal.Get(m => m.MachineName == machine.MachineName);
        }

       
    }
}
