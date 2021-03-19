using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Entities
{
    public class RoleCreatedConfirmation
    {
        /// <summary>
        /// Unique identifier for the role
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        public String RoleName { get; set; }
    }
}
