import React, { Component } from 'react';
import { Button } from 'react-bootstrap';
import axios from 'axios';

class TableComponent extends Component {
    render() { 
        if(this.props.dealTrackData){
            return <table width="100%" border="1">
            {this.props.dealTrackData.map((item =>
            <tr >
                <td>{item.dealNumber}</td>
                <td>{item.customerName}</td>
                <td>{item.dealerShip}</td>

                <td>{item.vechile}</td>

                <td>{item.price}</td>

            </tr>

            ))}
          </table>}
          else{
              return <span>No Data</span>
          }
        }
    }


class FileUpload extends Component {
    constructor(props) {
        super(props);
          this.state = {
            selectedFile: null,
            loaded: 0,
            dealTrackData: null,
          }
       
      }
    render() { 
        return <div>
        <input type="file" name="file" onChange={this.onChangeHandler}/>
        <br/>
        <Button type="button" class="btn btn-success btn-block" onClick={this.onClickHandler}>Upload</Button> 
        <br/><br/>
        <Button type="button" class="btn btn-success btn-block" onClick={this.onClickViewDataHandler}>View Data</Button> 
        <br/><br/>
<TableComponent dealTrackData={this.state.dealTrackData}></TableComponent>
    </div>;
    }
    onChangeHandler=event=>{
        this.setState({
            selectedFile: event.target.files[0],
            loaded: 1,
          })    
        }

        onClickViewDataHandler = () => 
        {
            axios.get("https://localhost:44391/DealTrack/"   
                ).then(res => { 
                   // this.state.dealTrackData = res.data
              console.log(res.data);
              this.setState({dealTrackData : res.data});
           })
        }

        onClickHandler = () => {
            const data = new FormData() 
            data.append('file', this.state.selectedFile);
            axios.post("https://localhost:44391/DealTrack/", 
                data
                ).then(res => { 
              console.log(res.statusText)
           })
        }
}
 
export default FileUpload;