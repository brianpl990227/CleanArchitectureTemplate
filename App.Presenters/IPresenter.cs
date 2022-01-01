using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get;}
    }
}
