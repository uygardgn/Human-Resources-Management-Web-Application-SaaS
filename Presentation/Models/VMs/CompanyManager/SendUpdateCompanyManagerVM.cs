﻿namespace Presentation.Models.VMs.CompanyManager
{
    public class SendUpdateCompanyManagerVM
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? ImagePath { get; set; }
    }
}
