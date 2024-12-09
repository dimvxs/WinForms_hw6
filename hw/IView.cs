using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    public interface IView
    {
        void UpdateButton(int index, Bitmap symbol);
        void ShowMessage(string message);
        bool EasyLevelSelected();
    }
}
