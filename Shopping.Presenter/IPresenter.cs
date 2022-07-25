using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Presenter
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
