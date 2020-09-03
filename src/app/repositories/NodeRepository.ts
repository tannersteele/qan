import { Note } from "../models/Note";

export class NodeRepository {
    add(note: Note) {
        console.log(note.content);
    }
}