interface IEmployee{
    id:number,
    name:string;
    address?:string;//Optional Property
}

let emp1:IEmployee={
  id:20,
  name:"sai",
  address:"lane1"
};

let emp2:IEmployee={
  id:3,
  name:'durga',
  address:'lane2'
}

let emp3:IEmployee={
    id:3,
    name:'prasda'
}

interface IFly
{
    fly();//Interface Method.
}


class Bird implements IFly
{
    //private name:string;
    //private id:number;
    constructor(private id:number,private name:string)
    {
       
    }

    DoEat()
    {
        console.log(`Bird withnId: ${this.id} and Name: ${this.name} is EATING`);
    }

    fly()
    {
        console.log(`Bird withnId: ${this.id} and Name: ${this.name} is FLYING`);
    }
}

let b1= new Bird(1,'Crow');//Instance Creation
//console.log(b1.name);//Can not access Private members of class.
b1.DoEat();//Access the Method.
b1.fly();//Access interface method.

class SpecialBird extends Bird
{
    SplFeature:string;
    Move()
    {
        super.DoEat();//Calling Base class function
    }
}

 var sp:SpecialBird = new SpecialBird(2,'Swan');
 sp.Move();
