using ObjectsAndClasses.Demo.Classes;

namespace ObjectsAndClasses.Demo;

internal class Program
{
    public static void Main()
    {
        #region Object Initialization, Default Constructor

        Person user = new Person();
        user.firstName = "Vadzim";
        user.lastName = "Kurdzesau";

        user.Introduce();

        #endregion

        #region Object Creation Without Fields Initialization

        //User anotherUser = new User();
        //anotherUser.Introduce();

        #endregion

        #region Use of Costructors

        //Admin admin = new Admin("NotVadzim", "NotKurdzesau");
        //admin.Introduce();

        ////Admin anotherAdmin = new Admin();

        #endregion

        #region Public Access to Fields

        //admin.firstName = null;
        //admin.Introduce();

        #endregion

        #region Use of Properties

        //Employee employee = new Employee("NotVadzim", "EPAM");
        //employee.Introduce();

        //employee.SetFirstName("Vadzim");
        //employee.LastName = "Kurdzesau";
        //employee.Introduce();

        #endregion

        #region Static class members

        //Manager firstManager = new Manager("Boss");
        //firstManager.Introduce();

        //Manager secondManager = new Manager("BigBoss");
        //secondManager.Introduce();

        //Manager.CompanyName = "Microsoft";
        //firstManager.Introduce();
        //secondManager.Introduce();

        #endregion
    }
}