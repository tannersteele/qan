import React from 'react';
import styles from './Popup.css';

export default function Popup(): JSX.Element {
  return (
    <div className={styles.container} data-tid="container">
      <input className={styles.popup_input} type="text" placeholder="Enter your note..." />
      <button>Add</button>
    </div>
  );
}
