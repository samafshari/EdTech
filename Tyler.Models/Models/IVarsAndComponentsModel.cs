using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public interface IVarsAndComponentsModel
{
    string Id { get; }
    Variable[]? Variables { get; set; }
    DataComponent[]? DataComponents { get; set; }
    long DataContainerId { get; set; }
}
