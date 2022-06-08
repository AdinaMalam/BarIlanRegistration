import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpService } from '../../http.service';

@Component({
  selector: 'app-identification',
  templateUrl: './identification.component.html',
  styleUrls: ['./identification.component.css']
})
export class IdentificationComponent implements OnInit {

  constructor(private httpService:HttpService, private router:Router) { }

  ngOnInit(): void {
  }

  msg: string = ""

  checkInstitutionSymbol(symbol:string) {
    this.httpService.getInstitution(symbol).subscribe(inst => {
      if (inst){
        this.router.navigate(['/update-details', inst.nvSchoolName, inst.iInstitutionId])
      }
      else{
        this.msg = "סמל המוסד לא קיים במערכת"
      }
    })
  }

}
