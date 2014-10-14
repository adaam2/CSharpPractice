using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Virtuals
    {
        public virtual Place thePlace { get; set; }
    }
    class VirtualSubClass : Virtuals
    {
        // Unlike abstract methods, with virtuals, you don't have to override thePlace from the parent class, but you can if you'd like.

        /// <summary>
        /// It is optional to override thePlace here
        /// </summary>
        public override Place thePlace
        {
            get
            {
                return base.thePlace;
            }
            set
            {
                base.thePlace = value;
            }
        }
    }
}
