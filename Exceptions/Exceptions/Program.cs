

//try
//{
//    //int a = 5;
//    //int b = 0;

//    //int res = a / b;

//    int[] nums = { 1, 2, 3 };

//    nums[6] = 100;
//}
//catch (NullReferenceException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Welcome");
//}


//static void Login (string username, string password)
//{
//    bool isSuccess = true;
//	try
//	{
//		if(username == "xxx" && password == "yyy")
//		{
//            isSuccess = true;
//            Console.WriteLine("Login success");
//        }
//        else
//        {
//            isSuccess = false;
//            throw new Exception("Email or password wrong");
//        }
//    }
//	catch (Exception ex)
//	{
//        Console.WriteLine(ex.Message);
//    }
//    finally
//    {
//        //if (isSuccess)
//        //{
//        //    Console.WriteLine("Email succeww sent");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Email failed sent");
//        //}
//        SendEmail(isSuccess);

//    }
//}

//Login("asdasd", "asdsad");

//static void SendEmail(bool isSuccess)
//{
//    if (isSuccess)
//    {
//        Console.WriteLine("Success email");
//    }
//    else
//    {
//        Console.WriteLine("Error email");
//    }

//}

using Exceptions;

static void GetEmployeeById(int? id)
{
	try
	{
        if (id is null)
        {
            throw new ArgumentNullException();
        }

        List<Employee> employees = new List<Employee>()
        {
        new Employee{Id = 1, FullName = "Kubra Memmedova" },
        new Employee{Id = 2, FullName = "Fidan Bashirova" },
        new Employee{Id = 3, FullName = "Surac Ismayilov" }
        };

        Employee emp = employees.FirstOrDefault(m => m.Id == id);

        if (emp is null)
        {
            throw new NotFountException();
        }
    }
	catch (NotFountException ex)
	{

        Console.WriteLine(ex.Message + " - " + ex.ErrorCode);
    }

}


GetEmployeeById(10);