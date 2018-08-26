using System;

namespace LogHolderAPI.Exceptions {

    /// <summary>
    /// Бросать в случае если не установлено необходимое поле
    /// </summary>
    public class RequriedFieldNotSetExceptioncs: Exception {

        public override string Message => $"Filed {this._filedName} is required and was not set";

        private string _filedName;

        public RequriedFieldNotSetExceptioncs(string filedName) {
            this._filedName = filedName;
        }
    }
}
