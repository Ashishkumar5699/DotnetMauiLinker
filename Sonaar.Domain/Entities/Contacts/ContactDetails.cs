using System;
using System.ComponentModel.DataAnnotations;
using Sonaar.Domain.Dto.CustomerDirectory;

namespace Sonaar.Domain.Entities.Contacts
{
	public class ContactDetails : ConsumerDTO
    {
        [Key]
        public int ContactId { get; set; }
    }
}

