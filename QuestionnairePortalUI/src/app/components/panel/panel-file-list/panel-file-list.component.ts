import { Component, OnInit } from '@angular/core';
import { FileDto } from 'src/app/models/fileDto';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { FileService } from 'src/app/services/file.service';

@Component({
  selector: 'app-panel-file-list',
  templateUrl: './panel-file-list.component.html',
  styleUrls: ['./panel-file-list.component.css']
})
export class PanelFileListComponent implements OnInit {
  files:FileDto[];
  constructor(private authService:AuthenticationService,
    private fileService:FileService) { }

  ngOnInit(): void {
    this.getCurrentUserFiles(this.authService.currentUserValue.userEmail);
  }

  getCurrentUserFiles(email:string){
    this.fileService.getByUserEmail(email).subscribe(response=>{
      this.files = response.listData;
    })
  }
}
