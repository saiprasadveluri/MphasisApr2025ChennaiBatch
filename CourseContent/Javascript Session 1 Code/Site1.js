function Employee(eid, name, dept) {//Constructor function
    this.EmployeetId = eid;//Public data member
    this.EmployeeName = name;//Public data member
    var Salary = 1000;//Private data member
    this.Department = dept;//Public data member

    this.ShowEmployeeId = function () {
    //Privilaged Function.It can access private data
    //and can be executed from Main.
        alert(this.EmployeetId);
        alert("From ShowEmployeeId method: " + Salary);//Allowed.
    }
}

Employee.prototype.DisplayDetails=function()//Public member function
{
    //alert('from DisplayDetails:'+ this.Salary);//Error.
    alert(this.EmployeeName);
}


function TestEmployeeObject()
{
    var eobj = new Employee("001", "Mary", "DEV");    
    eobj.DisplayDetails();//Public function
    eobj.ShowEmployeeId();//Prev Method.
    alert('From Main: ' + eobj.EmployeetId);//Access the Public data member
    //alert('Salary from mmain:'+ eobj.Salary);//Error. Can access private data menber.
}

function DoOperation() {
    alert("Saving the records");
}


function DoOperation2(itm) {
    var itm = 10;//Scope: Function scope
    val2 = 20;
    alert(itm);
}

