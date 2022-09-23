﻿using Flunt.Validations;
using MySchool.Common.ValueObjects;

namespace MySchool.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name() { }
        public Name(string firstName, string lastName)
        {
            FullName = firstName + lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsLowerOrEqualsThan(firstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 Caracters")
                .IsLowerOrEqualsThan(lastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 Caracters")
                .IsGreaterOrEqualsThan(firstName, 40, "Name.FirstName", "Nome deve conter no maximo 40 Caracters")
                );
        }

        public string FullName { get; set; }

    }
}
