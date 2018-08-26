namespace LogHolderAPI.Models.DTO_Input {

    /// <summary>
    /// Модель данных для <see cref="LogHolderAPI.Controllers.ProjectController.AddProject"/>
    /// </summary>
    public struct AddProjectModel {

        /// <summary>
        /// Имя проекта
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Описание проекта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Логотип проекта в бинарном формате
        /// </summary>
        public byte[] Photo { get; set; }

    }
}
