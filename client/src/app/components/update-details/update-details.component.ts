import { Component, OnChanges, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { HttpService } from 'src/app/http.service';
import { UserModel } from '../../models/user-model';
import {MatSnackBar} from '@angular/material/snack-bar';

@Component({
  selector: 'app-update-details',
  templateUrl: './update-details.component.html',
  styleUrls: ['./update-details.component.scss']
})
export class UpdateDetailsComponent implements OnInit, OnDestroy {
  title = 'user model';
  roles = ['מורה לביולוגיה', 'רכזת ביולוגיה', 'לבורנטית'];
  userModel = new UserModel("","","","","","","","",1, 1, new Date(), 1,new Date(), 1, "",1, 1);
  form:FormGroup = new FormGroup({});
  submitted = false;
  flagSuccess:boolean=true;
  flagFail:boolean=true;
  onSubmit(){
    if(!(this.userModel.password==this.userModel.confirmPassword)){
      this.submitted=true;
    }
    else
      this.submitted = true;
  }
  getCurrentModel() { 
    return JSON.stringify(this.userModel); 
  }

  subscription: Subscription = new Subscription; 
  schoolName: string = ""
  iinstituationId: string = ""

  constructor(private httpService:HttpService, private route:ActivatedRoute,private _snackBar: MatSnackBar) { }
  ngOnInit(): void {
    this.subscription = this.route.paramMap.subscribe(params => {
      this.schoolName = params.get('schoolName') || "" 
      this.iinstituationId = params.get('schoolSymbol') || ""
    })
  }

  public hasError = (controlName: string, errorName: string) =>{
    return this.form.controls[controlName].hasError(errorName);
  }

  addNewUser() {
    
    if(this.userModel.role==this.roles[0]){
      this.userModel.IInstitutionUserRoleId=614;
    }
    else if(this.userModel.role==this.roles[1]){
      this.userModel.IInstitutionUserRoleId=617;
    }
    else
      this.userModel.IInstitutionUserRoleId=613;
      if(!(this.userModel.password==this.userModel.confirmPassword)){        
        return;
      }
      this.userModel.IInstitutionId =parseInt(this.iinstituationId);
      this.httpService.addUser(this.userModel).subscribe(res=>{
      if(res.status==200){
         this.flagSuccess=false;
     }
      else{
           this.flagFail=false; 
      }
    })
   
  }
  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

  
}

