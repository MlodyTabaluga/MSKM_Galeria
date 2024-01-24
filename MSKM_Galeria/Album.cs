using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSKM_Galeria
{
    public class Album
    {
        public string Name { get; set; }    
        public ObservableCollection<Photo> Photos { get; set; }
    }
}
