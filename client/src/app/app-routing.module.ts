import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IdentificationComponent } from './components/identification/identification.component';
import { UpdateDetailsComponent } from './components/update-details/update-details.component';

const routes: Routes = [
  { path: "update-details/:schoolName/:schoolSymbol", component: UpdateDetailsComponent },
  { path: "identification", component: IdentificationComponent },
  { path: "", redirectTo: "identification", pathMatch:"full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
