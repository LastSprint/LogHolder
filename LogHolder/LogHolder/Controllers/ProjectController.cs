using LogHolderAPI.Models.DTO_Input;

using Microsoft.AspNetCore.Mvc;

using static System.String;

namespace LogHolderAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController: ControllerBase {

        [HttpPost]
        public object AddProject(AddProjectModel model) {
            if (IsNullOrEmpty(model.Name)) {
                con
            }
        }

    }
}
