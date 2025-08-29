import { Routes } from '@angular/router';
import { authGuard } from './guards/auth.guard';
import { AdminComponent } from './dashboard/admin/admin.component';
import { OwnerComponent } from './dashboard/owner/owner.component';
import { UserComponent } from './dashboard/user/user.component';
import { LoginComponent } from './auth/login/login.component';
import { ViewRestaurantComponent } from './dashboard/admin/view-restaurant/view-restaurant.component';
import { AddUserComponent } from './dashboard/admin/add-user/add-user.component';
import { UserListComponent } from './dashboard/admin/user-list/user-list.component';
import { OwnerOrderComponent } from './dashboard/owner/owner-order/owner-order.component';
import { OwnerRestroComponent } from './dashboard/owner/owner-restro/owner-restro.component';
import { UserOrdersComponent } from './dashboard/user/user-orders/user-orders.component';
import { UserMenuComponent } from './dashboard/user/user-menu/user-menu.component';
import { UserProfileComponent } from './dashboard/user/user-profile/user-profile.component';
import { EditRestaurantComponent } from './dashboard/admin/edit-restaurant/edit-restaurant.component';
import { EditUserComponent } from './dashboard/admin/edit-user/edit-user.component';

export const routes: Routes = [
    {
        path : '' , redirectTo :'auth/login' , pathMatch : 'full'
    },
    { path: '', component: LoginComponent}, 
    // {
    //     path : 'auth',
    //     loadChildren:()=> import('./auth/auth.module').then(m=>m.AuthModule)
    // },
    {
        path : 'dashboard',
        canActivate : [authGuard],
        children : [
            {
                path : 'admin' , component : AdminComponent , data :{
                    roles : ['Admin'] ,  
                },
               
                children: [
                  { path: 'view-restaurant', component: ViewRestaurantComponent },
                  { path: 'add-user', component: AddUserComponent },
                  { path: 'user-list', component: UserListComponent },
                  {
                    path : 'edit-user/:id' ,component : EditUserComponent
                  }
                ]
            },
            {
                path : 'owner' , component : OwnerComponent , data :{
                    roles : [ 'Owner' , 'Admin']
                }
                ,children : [
                    { path: 'owner-orders', component: OwnerOrderComponent },
                  { path: 'owner-restro', component: OwnerRestroComponent },
                
                ]
            },
            {
                path : 'user' , component : UserComponent , data :{
                    roles : ['User']
                },
                children: [
                    { path: 'user-orders', component: UserOrdersComponent },
                    { path: 'user-menu', component: UserMenuComponent },
                    { path: 'user-profile', component: UserProfileComponent }
                  ]

            },
        ]
    }
];
