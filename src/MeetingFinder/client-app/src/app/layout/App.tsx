import React, { useState, useEffect, Fragment } from 'react';
import axios from 'axios';
import { Header, Icon, Container } from 'semantic-ui-react';
import { IActivity } from '../models/activity';
import Navbar from '../../features/nav/navbar';
import MeetingDashboard from '../../features/meeting/MeetingDashboard';

const App = () => {
  const [activities, setActivities] = useState<IActivity[]>([]);
  useEffect(() => {
    axios.get<IActivity[]>('http://localhost:5000/api/activities')
      .then((response) => {
        setActivities(response.data)
      });
  }, []);

  return (
    <div>
      <Navbar />
      <Fragment/>
      <Container style={{marginTop: '7em'}}>
        <Header as='h2'>
          <Icon name='users' />
          <Header.Content>Meeting Finder</Header.Content>
        </Header>
        <MeetingDashboard activities={activities}/>
      </Container>
    </div>
  );

}

export default App;
