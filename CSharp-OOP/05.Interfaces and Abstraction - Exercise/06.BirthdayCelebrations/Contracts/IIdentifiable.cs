using System;
using System.Collections.Generic;
using System.Text;

namespace _06.BirthdayCelebrations.Contracts
{
    class IIdentifiable
    {
    }
}
namespace BirthdayCelebrations.Contracts
{
    public interface IIdentifiable
    {
        string Id { get; }
    }
}