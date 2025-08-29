import { inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn, Router, RouterStateSnapshot } from '@angular/router';
import { AuthService } from '../services/auth.service';

export const authGuard: CanActivateFn = (route : ActivatedRouteSnapshot, state :RouterStateSnapshot ) => {
  const auth = inject(AuthService);
  const router = inject(Router);
  const roles = route.data['roles'];

  if(auth.isLoggedIn() && auth.hasRole(roles)){
    return true;
  }
 router.navigate(['/auth/login']);
 return false;

};
