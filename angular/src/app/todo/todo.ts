import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TodoService } from '../proxy/todo.service';

@Component({
  selector: 'app-todo',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo.html',
  styleUrls: ['./todo.scss']
})
export class TodoComponent implements OnInit {

  todos: any[] = [];
  newTodoText = '';

  constructor(private todoService: TodoService) {}

  ngOnInit(): void {
    this.loadTodos();
  }

  loadTodos() {
    this.todoService.getList().subscribe(result => {
      this.todos = result;
    });
  }

  addTodo() {
    if (!this.newTodoText) return;

    this.todoService.create({text: this.newTodoText}).subscribe(() => {
      this.newTodoText = '';
      this.loadTodos();
    });
  }

  deleteTodo(id: string) {
    this.todoService.delete(id).subscribe(() => {
      this.loadTodos();
    });
  }
}
