const validator = new JustValidate('#new_dep');

validator
    .addField('#Name', [
        {
            rule: 'required',
            errorMessage: 'Department name is required'
        },
        {
            rule: 'minLength',
            value: 3,
            errorMessage: 'Department name must be 3 charachters length at least'
        },
        {
            rule: 'maxLength',
            value: 60,
            errorMessage: 'Department name can\'t exceed 60 charachters length'
        },
        //{
        //    validator: (value) => () =>
        //        fetch('url')
        //            .then(res => res.json())
        //            .then(data => data)
        //    ,
        //    errorMessage: 'Department name already exists!',
        //}
    ])
    .addField('#Code', [
        {
            rule: 'required',
            errorMessage: 'Department code is required'
        },
        {
            rule: 'minLength',
            value: 3,
            errorMessage: 'Department code must be 3 charachters length at least'
        },
        {
            rule: 'maxLength',
            value: 15,
            errorMessage: 'Department code can\'t exceed 15 charachters length'
        },
        {
            validator: (value) => () => {
                return fetch(`http://localhost:5001/department/?depcode=${encodeURIComponent(value)}`)
                    .then(function (res) {
                        return res.json()
                    })
                    .then(function (json) {
                        return json.available
                    });
            },
            errorMessage: 'Department code already exists!',
        }
    ])
    .onSuccess((event) => {
        document.getElementById("new_dep").submit();
    });