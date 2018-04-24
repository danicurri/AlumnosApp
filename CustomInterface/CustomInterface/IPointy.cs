using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    /// The pointy behavior as a read-only property.
    public interface IPointy
    {
        // Error! Interfaces cannot have data fields!
        // Error! Interfaces do not have constructors!
        // Error! Interfaces don't provide an implementation of members!

        byte Points { get; }
    }
}
