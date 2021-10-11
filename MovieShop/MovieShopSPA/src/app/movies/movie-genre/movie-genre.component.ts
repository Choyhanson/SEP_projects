import { Component, Input, OnInit } from '@angular/core';
import { Genre } from 'src/app/shared/models/genre';
import { ActivatedRoute } from '@angular/router';
import { GenreService } from 'src/app/core/services/genre.service';

@Component({
  selector: 'app-movie-genre',
  templateUrl: './movie-genre.component.html',
  styleUrls: ['./movie-genre.component.css']
})
export class MovieGenreComponent implements OnInit {
  genreId: number = 0;
  page:number=1;

  @Input() genreModel!:Genre;
  constructor(private route: ActivatedRoute, private genreService: GenreService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      p => {
        this.genreId = Number(p.get('genreId'));
        this.page=Number(p.get('page'));
        this.genreService.getAllMoviesByGenre(this.genreId,this.page).subscribe(
          m => {
            this.genreModel=m;
            console.log(m);
          }
        )
      });
  }
}