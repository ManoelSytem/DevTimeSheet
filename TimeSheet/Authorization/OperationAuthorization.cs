using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.Authorization
{
  
        public enum EOperation
        {
            get,
            create,
            edit,
            delete
        }

        public class OperationAuthorization : IAuthorizationRequirement
        {
            public string Operation { get; private set; }

            public OperationAuthorization(EOperation operation) => Operation = operation.ToString();
        }

        public class OperationAuthorizationHandler : AuthorizationHandler<OperationAuthorization>
        {
            protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorization requirement)
            {
                var controller = (ControllerActionDescriptor)((AuthorizationFilterContext)context.Resource).ActionDescriptor;
                if (context.User.HasClaim(c => c.Value == $"{controller.ControllerName}.{requirement.Operation}"))
                    context.Succeed(requirement);
                return Task.CompletedTask;
            }
        }
}
