/* eslint react/jsx-props-no-spreading: off */
import React from 'react';
import { Switch, Route } from 'react-router-dom';
import routes from './constants/routes.json';
import App from './containers/App';
import HomePage from './containers/HomePage';
import PopupPage from './containers/PopupPage';

// Lazily load routes and code split with webpacck
const LazyCounterPage = React.lazy(() =>
  import(/* webpackChunkName: "CounterPage" */ './containers/CounterPage')
);

export default function Routes() {
  return (
    <App>
      <Switch>
        <Route path={routes.POPUP} component={PopupPage} />
        <Route path={routes.HOME} component={HomePage} />
      </Switch>
    </App>
  );
}
