import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Article } from '../models/article.model';
import { ArticleData } from '../data/data';

@Component({
  selector: 'app-article',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.css']
})
export class ArticleComponent implements OnInit {

  private symbols: number = 250;

  articles: Article[] = [];

  @Input() article: Article | undefined;
  @Input() articleDesc: string = "";

  descToShow: string;
  articleDescLen: number;
  showReadMoreBtn: boolean = true;
  showHideBtn: boolean = false;
  imageIsShown: boolean = false;
  imageButtonTitle: string = "Show Image";

  constructor() {
    this.articleDescLen = 0;
    this.descToShow = '';
  }

  readMore(): void {
    this.articleDescLen = this.symbols;
  
    if (this.articleDescLen >=
      this.articleDesc.length) {
      this.showHideBtn = true;
      this.showReadMoreBtn = false;
      this.descToShow = this.articleDesc;
    } else {
      this.descToShow =
        this.articleDesc.substring(0, this.articleDescLen);
    }

  }

  hideDesc(): void {
    this.descToShow = '';
    this.articleDescLen = 0;
    this.showHideBtn = false;
    this.showReadMoreBtn = true;
  }

  toggleImage(): void {
    this.imageIsShown = !this.imageIsShown;
    this.imageButtonTitle = this.imageIsShown
      ? "Hide Image" : "Show Image";
  }

  ngOnInit() {
    const articleData = new ArticleData();
    this.articles = articleData.getData();

    if (this.articles.length > 0) {
      this.article = this.articles[0];
      this.articleDesc = this.article.description;
    }
  }
}