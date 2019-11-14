import React, { Component } from 'react';
import './App.css';
import Header from './Header';
import Lyrics from './Lyrics';

class App extends Component {
    constructor() {
        super();
        this.state = {
            lyrics: [ "" ],
            title: "Sufjo is Saddo",
        }
    }

    componentDidMount() {
        fetch("https://mastrchef.rocks/api/sufjan")
        .then(result => {
            return result.text();    
        })
        .then(result => {
            var lines = []
            result.split('\n').forEach(function(item){
                lines.push(<p>{item}</p>)
            });

            this.setState({lyrics: lines, title: "Sufjo is Saddo"})
        });
    }

    render() {
        return (
            <jsxFragment>
                <Header title={this.state.title} />
                <hr style={{width: "60vw"}} />
                <Lyrics lyrics={this.state.lyrics} />
            </jsxFragment>
        )
    }
}

export default App