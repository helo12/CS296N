using CaelumNavis.Models.Repos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class CustomerRepo :ICustomerRepo
	{
		

		AppDBContext context;
		public List<Customer> Customers
		{
			get { return this.context.Customers.ToList<Customer>(); }

		}


		public CustomerRepo(AppDBContext context)
		{
			this.context = context;
		}

		public void AddSent(Customer customer)
		{
			this.context.Customers.Add(customer);
			this.context.SaveChanges();
		}
		public void DeleteSent(Customer customer)
		{
			string id = "";
			//customer.CustomerID = id;
			//c.CustomerID == id ||
			Customers.Find((c) => {
				if (c.Name == customer.Name && c.Address == customer.Address && c.Email == customer.Email)
				{
					this.context.Customers.Remove(customer);
					this.context.SaveChanges();
					return true;
				}
				return false;
			});


		}
		//TODO
		public void UpdateMessage(Customer customer)
		{
			string id = "";
			customer.Id = id;

			Customers.Find((c) => {
				if (c.Id == id)
				{
					c.Name = customer.Name;
					c.Email = customer.Email;
					c.Address = customer.Address;
					c.City = customer.City;
					c.ZipCode = customer.ZipCode;
					c.CanContact = customer.CanContact;
					c.Terms = customer.Terms;
					this.context.Customers.Update(c);
					this.context.SaveChanges();
					return true;
				}
				return false;
			});
		}
		public CustomerVM GetSentMessageByUser(string Name)
		{
			CustomerVM customer = new CustomerVM();
			List<Customer> customers = new List<Customer>();
			customer.Customers = customers;

			Customer cust = new Customer();
			if (!String.IsNullOrEmpty(Name))
			{

				cust = this.Customers.Find((c) =>
				{
					if (c.Name == Name)
					{
						//customer.Customers.Add(c);
						return true;
					}
					else
					{
						return false;
					}

				});
			}
			customer.Customers.Add(cust);
			return customer;
		}

	}
}
