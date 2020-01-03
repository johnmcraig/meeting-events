import React, { Component } from 'react';
import './App.css';
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react';

class App extends Component {
  state = {
    values: []
  }
  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
      .then((response) => {
        this.setState({
          values: response.data
        })
      })
  }
  render() {
    return (
      <div>
        <Header as='h2'>
          <Icon name='users' />
          <Header.Content>Meetings &amp; Events</Header.Content>
        </Header>
          <ul>
            {this.state.values.map((values: any) => (
             <li key={values.id}>
              {values.name}
             </li>
          ))}
          </ul>
        
      </div>
    );
  }
  
}

export default App;
