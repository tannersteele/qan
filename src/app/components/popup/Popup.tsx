import * as React from "react"
import { Label, TextField, Stack, PrimaryButton } from "@fluentui/react"

type NotePopupProps = {
}

type NotePopupState = {
  newNote : string
}

class NotePopup extends React.Component<NotePopupProps, NotePopupState> {
  constructor(props : NotePopupProps) {
    super(props)
    this.state = {
        newNote: ""
    }
  }

  validateContent = (content: string) => {
    return content != null;
  }

  addNote = (event: React.FormEvent) => {
    event.preventDefault()
  }

  render = () => (
    <form onSubmit={this.addNote}>
    <Label htmlFor="newNote">New Note</Label>
        <Stack horizontal>
            <Stack.Item grow>
                <TextField 
                    validateOnLoad={false} 
                    placeholder=""
                    value={this.state.newNote}
                    id="newUrl"
                    name="newUrl" />
            </Stack.Item>
            <Stack.Item>
                <PrimaryButton 
                    disabled={!this.validateContent(this.state.newNote.trim())}
                    type="submit"
                    text="Add"/>
            </Stack.Item>
        </Stack>
    </form>
  )
}

export default NotePopup