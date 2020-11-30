import React, { useEffect, useState } from 'react'
import { Avatar } from '@material-ui/core'
import './LinkedIn.css'

const LinkedIn = () => {
	const [isLoading, setIsLoading] = useState(true)
	const [name, setName] = useState('')
	const [url, setUrl] = useState('')

	useEffect(() => {
		const findProfile = async () => {
			const response = await fetch('linkedin')
			const data = await response.json()
			console.log(data)
			setName(`${data.localizedFirstName} ${data.localizedLastName}`)
			setUrl(`https://www.linkedin.com/in/${data.vanityName}/`)
			setIsLoading(false)
		}
		findProfile()
	}, [])

	const loadingHtml = () => {
		return (
			<div>
				<p>
					<em>Loading...</em>
				</p>
			</div>
		)
	}

	const linkedInHtml = () => {
		return (
			<div>
				<a href={url} target='_blank' className='profile-link'>
					<Avatar src='https://media-exp1.licdn.com/dms/image/C4E03AQHoAEHMh2zgKg/profile-displayphoto-shrink_200_200/0?e=1612396800&amp;v=beta&amp;t=GzLN3RK_Be-mCu3sMLMpyyLcmgNkJzTQuj-2h3VLnLM' />
					<div>{name}</div>
				</a>
			</div>
		)
	}

	return <>{isLoading ? loadingHtml() : linkedInHtml()}</>
}

export default LinkedIn
