using System;
using SistemaVendedores.Models.ViewModels;

namespace SistemaVendedores.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}