import React from 'react'
import { Grid } from 'semantic-ui-react'
import { IActivity } from '../../app/models/activity'
import { MeetingList } from './MeetingList'

interface IProps {
    activities: IActivity[]
}

const MeetingDashboard: React.FC<IProps> = ({ activities }) => {
    return (
        <Grid>
            <Grid.Column width={10}>
                <MeetingList activities={activities} />
                {/* <List>
                    {activities.map((activity: any) => (
                        <List.Item key={activity.id}>
                            {activity.title}
                        </List.Item>
                    ))}
                </List> */}
            </Grid.Column>
        </Grid>
    )
}

export default MeetingDashboard;
