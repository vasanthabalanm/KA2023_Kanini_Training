import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  
})
export class HomeComponent implements OnInit {
  
  form!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      searchTerm: [''],
      minPrice: [''],
      maxPrice: ['']
    });

    window.addEventListener('scroll', () => {
      const image = document.getElementById('img');
      if (image) {
        const imagePosition = image.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;
        if (imagePosition < windowHeight) {
          image.classList.add('img3');
        } else {
          image.classList.remove('img3');
        }
      }
    })
    window.addEventListener('scroll', () => {
      const image = document.getElementById('img1');
      if (image) {
        const imagePosition = image.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;
        if (imagePosition < windowHeight) {
          image.classList.add('img3');
        } else {
          image.classList.remove('img3');
        }
      }
    })
    window.addEventListener('scroll', () => {
      const image = document.getElementById('img2');
      if (image) {
        const imagePosition = image.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;
        if (imagePosition < windowHeight) {
          image.classList.add('img3');
        } else {
          image.classList.remove('img3');
        }
      }
    })
    window.addEventListener('scroll', () => {
      const image = document.getElementById('img3');
      if (image) {
        const imagePosition = image.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;
        if (imagePosition < windowHeight) {
          image.classList.add('img3');
        } else {
          image.classList.remove('img3');
        }
      }
    })
  }
  locations: string[] = ['Banglore', 'chennai', 'coimbatore', 'delhi', 'gurugram', 'hyderabad', 'mumbai', 'noida', 'pune'];
  filteredLocations: string[] = [];
  searchTerm: string = '';
  minPrice: number | null = null;
  maxPrice: number | null = null;


  filterLocations() {
    
  }
  showDropdown: boolean = false;
  placeholderText: string = 'Location';
  pristine:boolean=false;



  searchLocations() {
    if ((this.searchTerm.length >= 0) || (this.searchTerm.length <= 0)) {
      this.filteredLocations = this.locations.filter(location =>
        location.toLowerCase().startsWith(this.searchTerm.toLowerCase())
      );
      this.showDropdown = true;
    } else {
      this.filteredLocations = [];
      this.showDropdown = false;
    }
  }

  selectLocation(location: string) {
    this.searchTerm = location
    this.showDropdown = false;    
  }
  handleSubmit(event: Event) {
    event.preventDefault();
    // Handle form submission logic here
  }
  

}
