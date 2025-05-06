using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages 
    { 
        public static string? AuthorizationDenied = "You do not have access to this authorization area";
        public static string UserRegistered = "Successfully registered";
        public static string UserNotRegistered = "Registration failed";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Incorrect password";
        public static string SuccessfulLogin = "Login successful";
        public static string UserAlreadyExists = "This email is already registered in the system";
        public static string AccessTokenCreated = "Logged in";
        public static string CreatedUserOperationClaim = "Role assigned to the user";
        public static string UpdatedUserOperationClaim = "User's role updated";
        public static string DeleteddUserOperationClaim = "User's role deleted";
      
        public static string MachineAdded = "Machine added";
        public static string MachineAlreadtExists = "This machine already exists";

        public static string OrderCreated = "Order created";
        public static string OrderNotExist = "Order does not exist";

        public static string WashAdded = "Washing started";
        public static string WashAlreadtExists = "This wash process was already created";
        public static string WashInProgress = "There is currently a washing process, washing cannot be started";
        public static string MachineBusy = "Machine busy, washing cannot be started";

        public static string QualityControlCreated = "Quality Control created";

        public static string OrderDefectAdded = "Desicion added";
        public static string OrderDefectUpdated = "Desicion updated";

        public static string QualityControlUpdated = "Final desicion updated";
    }
}
