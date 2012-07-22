/// <reference path="../jquery-1.7.2.js" />

$(function () {
    var viewModel = kendo.observable({
        name: "",
        basicInfoItems: [],
        experienceItems: [],
        educationItems: [],
        skillsParagraphs: []
    });
    $.get("/api/Curricula", function (data) {
        var $xml = $(data);
        var basicInfoItems = $.map($xml.find("BasicInfoItems Item"), function (element) {
            return { key: $(element).find("Key").text(), value: $(element).find("Value").text() };
        });
        var experienceItems = $.map($xml.find("ExperienceItems ExperienceItem"), function (element) {
            var $element = $(element);
            return {
                companyName: $element.find("CompanyName").text(),
                location: $element.find("Location").text(),
                jobTitle: $element.find("JobTitle").text(),
                timeframe: $element.find("Timeframe").text(),
                description: $element.find("JobDescription").text()

            };
        });
        var educationItems = $.map($xml.find("EduactionItems Item"), function (element) {
            return { key: $(element).find("Key").text(), value: $(element).find("Value").text() };
        });
        var skillsParagraphs = $.map($xml.find("SkillsParagraphs Paragraph"), function (element) {
            return { value: $(element).text() };
        });
        viewModel.set("name", $xml.find("Name").text());
        viewModel.set("basicInfoItems", basicInfoItems);
        viewModel.set("experienceItems", experienceItems)
        viewModel.set("educationItems", educationItems);
        viewModel.set("skillsParagraphs", skillsParagraphs);
    }, "xml");

    kendo.bind($(".container"), viewModel);
});