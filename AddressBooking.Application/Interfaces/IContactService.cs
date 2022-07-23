﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooking.Application
{
    public interface IContactService
    {
        Task<IEnumerable<ContactDto>> GetContactsAsync(CancellationToken cancellationToken);
    }
}