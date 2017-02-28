using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.Standard
{
	public partial class LabelView : ContentView
	{
		public LabelView ()
		{
        }

	    public IReadonlyViewModel Model
	    {
            set { BindingContext = value; }
	    }
	}

    public interface IReadonlyViewModel
    {
        
    }
}
