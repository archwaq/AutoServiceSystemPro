using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemUI
{
    public interface IClientRequester
    {
        void ClientComplete(ClientModel model);
    }
}
