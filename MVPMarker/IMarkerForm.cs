using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPMarker.Model;
using System.Drawing;

namespace MVPMarker
{
    interface IMarkerForm
    {
        ImageModel Model { get; set; }
    }
}
