export class Note {
    content: string;
    timestamp: Date;

    constructor(content: string) {
        this.content = content;
        this.timestamp = new Date();
    }
}