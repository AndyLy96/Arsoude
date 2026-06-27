import { Component, inject } from '@angular/core';
import { HelloworldService } from '../service/helloworld.service';
import { Router } from '@angular/router';
import { Storage, getDownloadURL, ref, uploadBytesResumable } from '@angular/fire/storage';
import { FilterDTO } from '../models/FilterDTO';
import { TrailService } from '../service/trail.service';
import { TrailDTO } from '../models/TrailDTO';
import { TranslateService } from '@ngx-translate/core';
import { NotifierService } from '../notifier.service';
import VanillaTilt from 'vanilla-tilt';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent {
hello : String = "pas de bonjour :C";
filter : FilterDTO = new FilterDTO();
private readonly storage: Storage = inject(Storage);
trails : TrailDTO[] = []
searchInput: string = "";
completedTrails : TrailDTO[] = [];

constructor(private helloService : HelloworldService, 
  private router: Router, 
  private trailService : TrailService, 
  private translate: TranslateService,
  private notifierService: NotifierService, private http:HttpClient){}

  async ngOnInit(): Promise<void> {
    const trailCard = document.querySelector<HTMLElement>("trailCard");
    if (trailCard) {
        VanillaTilt.init(trailCard, {
            max: 25,
            speed: 400
        });
    }

    this.completedTrails = await this.trailService.completedTrails();
    console.log(this.completedTrails, "Jj");
}


  async GetHello() : Promise<void> {
    this.hello = await this.helloService.GetWord()
  }

  async uploadFile(input: HTMLInputElement) {
    if (!input.files) return
  
    const files: FileList = input.files;
  
    for (let i = 0; i < files.length; i++) {
        const file = files.item(i);
        if (file) {
            const storageRef = ref(this.storage, file.name);
            await uploadBytesResumable(storageRef, file);
            let test = await getDownloadURL(storageRef);
            console.log(test);
        }
    }
  }

  onEnter() : void {
    const searchObject = new FilterDTO(this.searchInput);
    localStorage.setItem("Search", JSON.stringify(searchObject));
    this.router.navigate(['/search']);
  }

  async FilterTrail(){
    this.trails = await this.trailService.searchTrails(this.filter);
  }

 
}
