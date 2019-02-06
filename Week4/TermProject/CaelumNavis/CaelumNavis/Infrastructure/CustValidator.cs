using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaelumNavis.Models;
namespace CaelumNavis.Infrastructure
{
	public class CustValidator : UserValidator<Customer>
	{
		

			public override async Task<IdentityResult> ValidateAsync(
					UserManager<Customer> manager,
					Customer customer)
			{

				IdentityResult result = await base.ValidateAsync(manager, customer);

				List<IdentityError> errors = result.Succeeded ?
					new List<IdentityError>() : result.Errors.ToList();

				if (!customer.Email.ToLower().EndsWith("@example.com"))
				{
					errors.Add(new IdentityError
					{
						Code = "EmailDomainError",
						Description = "Only example.com email addresses are allowed"
					});
				}

				return errors.Count == 0 ? IdentityResult.Success
					: IdentityResult.Failed(errors.ToArray());
			}
		}
	}


