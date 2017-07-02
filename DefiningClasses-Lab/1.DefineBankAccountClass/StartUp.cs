using System;
using System.Collections.Generic;


public class StartUp
{
	static void Main()
	{
		var accounts = new Dictionary<int, BankAccount>();
		var input = Console.ReadLine();

		while (input != "End")
		{
			var cmdArr = input.Split();
			switch (cmdArr[0])
			{
				case "Create":
					Create(cmdArr, accounts);
					break;
				case "Deposit":
					Deposit(cmdArr, accounts);
					break;
				case "Withdraw":
					Withdraw(cmdArr, accounts);
					break;
				case "Print":
					Print(cmdArr, accounts);
					break;
			}
			input = Console.ReadLine();
		}
	}

	private static void Print(string[] cmdArr, Dictionary<int, BankAccount> accounts)
	{
		var id = int.Parse(cmdArr[1]);
		if (!accounts.ContainsKey(id))
		{
			Console.WriteLine("Account does not exist");
		}
		else
		{
			Console.WriteLine(accounts[id].ToString());
		}
	}

	private static void Withdraw(string[] cmdArr, Dictionary<int, BankAccount> accounts)
	{
		var id = int.Parse(cmdArr[1]);
		var amount = double.Parse(cmdArr[2]);
		if (accounts.ContainsKey(id))
		{
			if (accounts[id].Balance < amount)
			{
				Console.WriteLine("Insufficient balance");
			}
			else
			{
				accounts[id].Withdraw(amount);
			}
		}
		else
		{
			Console.WriteLine("Account does not exist");
		}
	}

	private static void Deposit(string[] cmdArr, Dictionary<int, BankAccount> accounts)
	{
		var id = int.Parse(cmdArr[1]);
		var amount = double.Parse(cmdArr[2]);
		if (accounts.ContainsKey(id))
		{
			if (amount > 0)
			{
				accounts[id].Deposit(amount);
			}
		}
		else
		{
			Console.WriteLine("Account does not exist");
		}
	}

	private static void Create(string[] cmdArr, Dictionary<int, BankAccount> accounts)
	{
		var id = int.Parse(cmdArr[1]);
		if (accounts.ContainsKey(id))
		{
			Console.WriteLine("Account already exists");
		}
		else
		{
			var acc = new BankAccount();
			acc.ID = id;
			accounts.Add(id, acc);
		}
	}
}
