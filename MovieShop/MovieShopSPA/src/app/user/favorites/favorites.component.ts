import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/core/services/user.service';
import { Favorite } from 'src/app/shared/models/favorite';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {

  favorites!:Favorite[];
  constructor(private userService:UserService) { }

  ngOnInit(): void {
    this.userService.getUserFavorites().subscribe(f =>
      {
        this.favorites=f;
      })
  }

}
