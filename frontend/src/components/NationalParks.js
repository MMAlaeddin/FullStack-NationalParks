import React from 'react';
import { connect } from "react-redux";
import { makeApiCall } from "./actions";


class NationalParks extends React.Component {
  constructor(props) {
    super(props);
  }

  // makeApiCall = () => {
  //   fetch(`https://api.nytimes.com/svc/topstories/v2/home.json?api-key=${process.env.REACT_APP_API_KEY}`)
  //     .then(response => response.json())
  //     .then(
  //       (jsonifiedResponse) => {
  //         this.setState({
  //           isLoaded: true,
  //           headlines: jsonifiedResponse.results
  //         });
  //       })
  //     .catch((error) => {
  //       this.setState({
  //         isLoaded: true,
  //         error
  //       });
  //     });
  // }

  componentDidMount() {
    // this.makeApiCall()
    const { dispatch } = this.props;
    dispatch(makeApiCall());
  }

  render() {
    const { error, isLoading, headlines } = this.props;
    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>
    } else if (!isLoading) {
      return <React.Fragment>Loading. . .</React.Fragment>;
    } else {
      return (
        <React.Fragment>
          <h1>NationalParks</h1>
          <ul>
            {nationalParks.map((nationalParks, index) =>
              <li key={index}>
                <h3>{nationalParks.title}</h3>
                <p>{nationalParks.abstract}</p>
              </li>
            )}
          </ul>
        </React.Fragment>
      );
    }
  }
}
const mapStateToProps = state => {
  return {
    nationalParks: state.nationalParks,
    isLoading: state.isLoading,
    error: state.error
  }
}

export default connect(mapStateToProps)(NationalParks);