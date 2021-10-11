import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/core/services/user.service';
import { Purchase } from 'src/app/shared/models/purchase';

@Component({
  selector: 'app-purchases',
  templateUrl: './purchases.component.html',
  styleUrls: ['./purchases.component.css']
})
export class PurchasesComponent implements OnInit {

  purchases!:Purchase[];

  constructor(private userService:UserService) { }

  ngOnInit(): void {
    this.userService.getUserPurchases()
    .subscribe(
      p =>{
      this.purchases=p;
    } )
  }

}
