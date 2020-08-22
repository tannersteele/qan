import React from 'react';
import styles from './Home.css';
import { useDispatch } from 'react-redux';
import { push } from 'connected-react-router'
import routes from '../constants/routes.json';

export default function Home(): JSX.Element {
  const dispatch = useDispatch();
  return (
    <div className={styles.container} data-tid="container">
      <h2>Home</h2>
      <div>
        <button onClick={() =>
        {
          dispatch(push(routes.POPUP));
        }}>
          Go to popup
        </button>
      </div>
    </div>
  );
}
