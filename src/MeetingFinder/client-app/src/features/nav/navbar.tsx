import React from 'react'
import { Menu, Container, Button } from 'semantic-ui-react';

export const Navbar = () => {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 10}}/>
                    Meeting Finder
                </Menu.Item>
                <Menu.Item name='home'/>
                <Menu.Item>
                    <Button positive content='Create Meeting'></Button>
                </Menu.Item>
            </Container>
        </Menu>
    )
}

export default Navbar;
