import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { authGuard } from '../guards/auth.guard';
import { UserComponent } from './user/user.component';
import { UserListComponent } from './admin/user-list/user-list.component';
import { AddUserComponent } from './admin/add-user/add-user.component';
import { ViewRestaurantComponent } from './admin/view-restaurant/view-restaurant.component';
import { AddRestaurantComponent } from './admin/add-restaurant/add-restaurant.component';
import { EditRestaurantComponent } from './admin/edit-restaurant/edit-restaurant.component';
import { EditUserComponent } from './admin/edit-user/edit-user.component';
import { OwnerOrderComponent } from './owner/owner-order/owner-order.component';
import { OwnerRestroComponent } from './owner/owner-restro/owner-restro.component';
import { UserOrdersComponent } from './user/user-orders/user-orders.component';
import { UserMenuComponent } from './user/user-menu/user-menu.component';
import { UserProfileComponent } from './user/user-profile/user-profile.component';

const routes: Routes = [
  {
    path: 'admin',
    component: AdminComponent,
    canActivate :[authGuard] , 
    data: { roles: ['Admin'] },
    children: [
      { path: '', redirectTo: 'user-list', pathMatch: 'full' },
      { path: 'user-list', component: UserListComponent },
      { path: 'add-user', component: AddUserComponent },
      { path: 'edit-user/:id', component: EditUserComponent },
      { path: 'view-restaurant', component: ViewRestaurantComponent },
      { path: 'add-restaurant', component: AddRestaurantComponent },
      { path: 'edit-restaurant/:id', component: EditRestaurantComponent },


    ]
  },
  {
    path: 'owner',
    data: { roles: ['Owner'] },
    children: [
      { path: 'owner-order', component: OwnerOrderComponent },
      { path: 'owner-restro', component: OwnerRestroComponent },

    ]
  },
  {
    path: 'user',
    data: { roles: ['User'] },
    children: [

      { path: 'user-orders', component: UserOrdersComponent },
      { path: 'user-menu', component: UserMenuComponent },
      { path: 'user-profile', component: UserProfileComponent }


    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
