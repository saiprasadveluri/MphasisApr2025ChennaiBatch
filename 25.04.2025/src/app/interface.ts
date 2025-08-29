export interface User {
  id?: string;
  email?: string;
  role?: string;
  password?: string,
  name?: string,
  location?: string,


}

export interface Restro {
  id: string,
  name:string,
  location :string,
  owner: number
}

export interface order {
id: string
uid: string ,
rid: string,
dishname: string,
price : string , 
quantity: number

}
